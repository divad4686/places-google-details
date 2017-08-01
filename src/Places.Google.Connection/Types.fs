[<AutoOpen>]
module Places.Google.Types

type PlaceId = PlaceId of string
type PlaceName = PlaceName of string

type CountryCode = CountryCode of string

type PlaceDetail = {countryCode:CountryCode;placesName:seq<PlaceName>}
