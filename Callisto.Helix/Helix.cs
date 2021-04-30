using System.Collections.Generic;

namespace Callisto.Helix
{
    public record HelixResult
    {
        public bool Succeeded { get; set; }
        public List<string> Errors { get; set; }

        public static HelixResult Success => new() { Succeeded = true };
        public static HelixResult Failed(List<string> errors) => new() { Errors = errors };
        public static HelixResult Failed(string error) => new() { Errors = new List<string> { error } };
    }

    public record HelixValueResult<T> : HelixResult
    {
        public T Value { get; set; }
        public static new HelixValueResult<T> Success(T value) => new() { Succeeded = true, Value = value };
        public static new HelixValueResult<T> Failed(List<string> errors) => new() { Errors = errors };
        public static new HelixValueResult<T> Failed(string error) => new() { Errors = new List<string> { error } };
    }
}