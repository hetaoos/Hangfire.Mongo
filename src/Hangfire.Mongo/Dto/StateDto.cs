﻿using System;
using System.Collections.Generic;
using Hangfire.Mongo.Serializers;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Hangfire.Mongo.Dto
{
#pragma warning disable 1591
    public class StateDto
    {
        [BsonId]
        public ObjectId Id { get; set; }

        public int JobId { get; set; }

        public string Name { get; set; }

        public string Reason { get; set; }

        public DateTime CreatedAt { get; set; }
        [BsonSerializer(typeof(StateDtoDataFieldSerializer))]
        public Dictionary<string, string> Data { get; set; }
    }
#pragma warning restore 1591
}