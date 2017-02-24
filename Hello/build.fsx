#r "../packages/FAKE/tools/FakeLib.dll"

open Fake

Target "Deploy" (fun _ ->
    trace "Heavy deploy action"
)

Target "Default" (fun _ ->
    trace "Hello World from FAKE"
)

RunTargetOrDefault "Default"
