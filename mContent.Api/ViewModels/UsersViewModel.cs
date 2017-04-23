namespace mContent.Api.ViewModels
{
    using System;

    using Newtonsoft.Json;

    /// <summary>
    /// User View Model
    /// </summary>
    public class UsersViewModel
    {
        [JsonProperty("id", Required = Required.Always)]
        public int Id { get; set; }

        [JsonProperty("first_name", Required = Required.Always)]
        public string FirstName { get; set; }

        [JsonProperty("last_name", Required = Required.Always)]
        public string LastName { get; set; }

        [JsonProperty("username", Required = Required.Always)]
        public string UserName { get; set; }

        [JsonProperty("password", Required = Required.Always)]
        public string Password { get; set; }

        [JsonProperty("email", Required = Required.Always)]
        public string Email { get; set; }

        [JsonProperty("created_date", Required = Required.AllowNull)]
        public DateTime CreatedDate { get; set; }

        [JsonProperty("updated_date", Required = Required.AllowNull)]
        public DateTime? UpdatedDate { get; set; }

        [JsonProperty("activated", Required = Required.Always)]
        public bool Activated { get; set; }
    }
}