﻿using BaltaStore.Shared.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaltaStore.Domain.StoreContext.Commands.CustomerCommands.Outputs
{
    public class ResponseCommand : ICommandResult
    {
        public ResponseCommand(bool success, string message, object data)
        {
            Success = success;
            Message = message;
            Data = data;
        }

        public bool Success { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}
