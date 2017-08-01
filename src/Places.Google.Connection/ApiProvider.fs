module Places.Google.ApiProvider

open FSharp.Data

type ApiUrl = ApiUrl of string

[<Literal>]
let ApiKey = "AIzaSyDHletMpocdr_P5jtTZq20nOKohOiD_1QQ"
[<Literal>]
let DetailsExample = "https://maps.googleapis.com/maps/api/place/details/json?placeid=ChIJN1t_tDeuEmsRUsoyG83frY4&key=" + ApiKey

type DetailsProvider = JsonProvider<DetailsExample>

