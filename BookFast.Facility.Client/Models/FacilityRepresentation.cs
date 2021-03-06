// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace BookFast.Facility.Client.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class FacilityRepresentation
    {
        /// <summary>
        /// Initializes a new instance of the FacilityRepresentation class.
        /// </summary>
        public FacilityRepresentation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FacilityRepresentation class.
        /// </summary>
        public FacilityRepresentation(int id, string name, string streetAddress, int accommodationCount, string description = default(string), double? longitude = default(double?), double? latitude = default(double?), IList<string> images = default(IList<string>))
        {
            Id = id;
            Name = name;
            Description = description;
            StreetAddress = streetAddress;
            Longitude = longitude;
            Latitude = latitude;
            Images = images;
            AccommodationCount = accommodationCount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "streetAddress")]
        public string StreetAddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "longitude")]
        public double? Longitude { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "latitude")]
        public double? Latitude { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "images")]
        public IList<string> Images { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "accommodationCount")]
        public int AccommodationCount { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (StreetAddress == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StreetAddress");
            }
        }
    }
}
