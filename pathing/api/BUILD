load("@rules_proto//proto:defs.bzl", "proto_library")
load("@io_bazel_rules_go//proto:def.bzl", "go_proto_library", "go_grpc_library")

package(default_visibility=["//visibility:public"])

proto_library(
    name = "constants_proto",
    srcs = ["constants.proto"],
)

go_proto_library(
    name = "constants_go_proto",
    importpath = "github.com/downflux/game/pathing/api/constants_go_proto",
    proto = ":constants_proto",
)

proto_library(
    name = "data_proto",
    srcs = ["data.proto"],
    deps = [
        ":constants_proto",
	"//api:data_proto",
    ],
)

go_proto_library(
    name = "data_go_proto",
    importpath = "github.com/downflux/game/pathing/api/data_go_proto",
    proto = ":data_proto",
    deps = [
        ":constants_go_proto",
	"//api:data_go_proto",
    ],
)
