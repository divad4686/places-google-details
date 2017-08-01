module Places.Google.DetailsConnection
open Places.Google.ApiProvider

type Url = Url of string
let UrlValue (Url url) = url
let DetailsUrl = Url ("https://maps.googleapis.com/maps/api/place/details/json?key=" + ApiKey)

let WithSearchId (PlaceId placeId) (Url url) = Url(url + "&placeid=" + placeId)

let GetDetailsUrl placeId = DetailsUrl |> WithSearchId placeId

let LoadData = GetDetailsUrl >> UrlValue >> ApiProvider.DetailsProvider.Load