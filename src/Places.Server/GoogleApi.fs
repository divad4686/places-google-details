module GoogleApi

open FSharp.Data
[<Literal>]
let url = "https://maps.googleapis.com/maps/api/place/autocomplete/json?input=Amoeba&types=establishment&location=37.76999,-122.44696&radius=500&key=AIzaSyDHletMpocdr_P5jtTZq20nOKohOiD_1QQ"
type googlePlaces = JsonProvider<url>
