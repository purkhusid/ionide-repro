module Service

open Grpc.Core
open Src.Protobuf.Bootstrap.Service
open Src.Protobuf.Bootstrap.Models
open System.Threading.Tasks


type BootstrapImpl() =
    inherit BootstrapService.BootstrapServiceBase()
