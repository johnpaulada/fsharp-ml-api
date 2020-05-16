namespace API.Controllers

open System
open System.Collections.Generic
open System.Linq
open System.Threading.Tasks
open Microsoft.AspNetCore.Mvc
open Microsoft.Extensions.Logging
open API

[<ApiController>]
[<Route("[controller]")>]
type SentimentController (logger : ILogger<SentimentController>) =
    inherit ControllerBase()

    [<HttpGet>]
    member __.Get() : string =
        let parms = __.Request.Query |> Seq.head |> fun kvp -> (kvp.Key, kvp.Value |> Seq.head)

        match parms with
            | ("text", value) -> Model.predict(value)
            | _ -> ""