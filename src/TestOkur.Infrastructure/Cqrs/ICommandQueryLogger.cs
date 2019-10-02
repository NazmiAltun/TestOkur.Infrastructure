﻿namespace TestOkur.Infrastructure.Cqrs
{
    using System.Threading.Tasks;

    public interface ICommandQueryLogger
    {
        Task LogAsync(string serializedMessage);
    }
}
