package produce

import (
	"github.com/downflux/game/engine/fsm/action"
	"github.com/downflux/game/engine/fsm/fsm"
	"github.com/downflux/game/engine/id/id"
	"github.com/downflux/game/engine/status/status"
	"github.com/downflux/game/engine/visitor/visitor"

	gcpb "github.com/downflux/game/api/constants_go_proto"
	gdpb "github.com/downflux/game/api/data_go_proto"
	fcpb "github.com/downflux/game/engine/fsm/api/constants_go_proto"
)

const (
	fsmType  = fcpb.FSMType_FSM_TYPE_PRODUCE
	idLength = 16
)

var (
	unknown   = fsm.State(fcpb.CommonState_COMMON_STATE_UNKNOWN.String())
	pending   = fsm.State(fcpb.CommonState_COMMON_STATE_PENDING.String())
	executing = fsm.State(fcpb.CommonState_COMMON_STATE_EXECUTING.String())
	canceled  = fsm.State(fcpb.CommonState_COMMON_STATE_CANCELED.String())
	finished  = fsm.State(fcpb.CommonState_COMMON_STATE_FINISHED.String())

	transitions = []fsm.Transition{
		{From: pending, To: executing, VirtualOnly: true},
		{From: pending, To: canceled},
		{From: executing, To: finished},
	}
	FSM = fsm.New(transitions, fsmType)
)

type Action struct {
	*action.Base

	id            id.ActionID     // Read-only.
	tick          id.Tick         // Read-only.
	executionTick id.Tick         // Read-only.
	dfStatus      *status.Status  // Read-only.
	entityType    gcpb.EntityType // Read-only.
	spawnPosition *gdpb.Position  // read-only.
}

func New(
	dfStatus *status.Status,
	executionTick id.Tick,
	entityType gcpb.EntityType,
	spawnPosition *gdpb.Position) *Action {
	return &Action{
		Base:          action.New(FSM, pending),
		id:            id.ActionID(id.RandomString(idLength)),
		executionTick: executionTick,
		dfStatus:      dfStatus,
		entityType:    entityType,
		spawnPosition: spawnPosition,
	}
}

func (n *Action) EntityType() gcpb.EntityType    { return n.entityType }
func (n *Action) Accept(v visitor.Visitor) error { return v.Visit(n) }
func (n *Action) ID() id.ActionID                { return n.id }
func (n *Action) SpawnPosition() *gdpb.Position  { return n.spawnPosition }

func (n *Action) Precedence(i action.Action) bool {
	if i.Type() != fsmType {
		return false
	}

	return n.tick > i.(*Action).tick
}

func (n *Action) Finish() error {
	s, err := n.State()
	if err != nil {
		return err
	}

	return n.To(s, finished, false)
}

func (n *Action) Cancel() error {
	s, err := n.State()
	if err != nil {
		return err
	}

	return n.To(s, canceled, false)
}

func (n *Action) State() (fsm.State, error) {
	tick := n.dfStatus.Tick()

	s, err := n.Base.State()
	if err != nil {
		return unknown, err
	}

	switch s {
	case pending:
		if tick >= n.executionTick {
			if err := n.To(s, executing, true); err != nil {
				return unknown, err
			}
			return executing, nil
		}
		return pending, nil
	default:
		return s, nil
	}
}