﻿namespace GraphQLAPI.Schema.Queries.Ratings
{
    public class RatingType
    {
        public Guid Id { get; set; }
        public string? Review { get; set; }
        public string? Start { get; set; }
    }
}
