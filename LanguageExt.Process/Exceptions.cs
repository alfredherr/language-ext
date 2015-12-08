﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LanguageExt
{
    /// <summary>
    /// Named process already exists
    /// </summary>
    [Serializable]
    public class NamedProcessAlreadyExistsException : Exception
    {
        /// <summary>
        /// Ctor
        /// </summary>
        public NamedProcessAlreadyExistsException()
            :
            base("Named process already exists")
        {
        }

        /// <summary>
        /// Ctor
        /// </summary>
        public NamedProcessAlreadyExistsException(string message) : base(message)
        {
        }

        /// <summary>
        /// Ctor
        /// </summary>
        public NamedProcessAlreadyExistsException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    /// <summary>
    /// Invalid process name
    /// </summary>
    [Serializable]
    public class InvalidProcessNameException : Exception
    {
        /// <summary>
        /// Ctor
        /// </summary>
        public InvalidProcessNameException()
            :
            base("Invalid process name")
        {
        }

        /// <summary>
        /// Ctor
        /// </summary>
        public InvalidProcessNameException(string message) : base(message)
        {
        }

        /// <summary>
        /// Ctor
        /// </summary>
        public InvalidProcessNameException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    /// <summary>
    /// Invalid process ID
    /// </summary>
    [Serializable]
    public class InvalidProcessIdException : Exception
    {
        /// <summary>
        /// Ctor
        /// </summary>
        public InvalidProcessIdException()
            :
            base("Invalid process ID")
        {
        }

        /// <summary>
        /// Ctor
        /// </summary>
        public InvalidProcessIdException(string message) : base(message)
        {
        }

        /// <summary>
        /// Ctor
        /// </summary>
        public InvalidProcessIdException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    /// <summary>
    /// NoChildProcessesException
    /// </summary>
    [Serializable]
    public class NoChildProcessesException : Exception
    {
        /// <summary>
        /// Ctor
        /// </summary>
        public NoChildProcessesException()
            :
            base("No child processes")
        {
        }

        /// <summary>
        /// Ctor
        /// </summary>
        public NoChildProcessesException(string message) : base(message)
        {
        }

        /// <summary>
        /// Ctor
        /// </summary>
        public NoChildProcessesException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    /// <summary>
    /// A process threw an exception in its message loop
    /// </summary>
    [Serializable]
    public class ProcessException : Exception
    {
        /// <summary>
        /// Process that threw the exception
        /// </summary>
        public string Self;

        /// <summary>
        /// Process that sent the message
        /// </summary>
        public string Sender;

        /// <summary>
        /// Ctor
        /// </summary>
        [JsonConstructor]
        public ProcessException(string message, string self, string sender, Exception innerException)
            :
            base(message, innerException)
        {
            Self = self;
            Sender = sender;
        }
    }

    /// <summary>
    /// A process threw an exception in its setup function
    /// </summary>
    [Serializable]
    public class ProcessSetupException : Exception
    {
        /// <summary>
        /// Process that threw the exception
        /// </summary>
        public string Self;

        /// <summary>
        /// Ctor
        /// </summary>
        [JsonConstructor]
        public ProcessSetupException(string self, Exception innerException)
            :
            base("Process failed to start: "+self, innerException)
        {
            Self = self;
        }
    }

    /// <summary>
    /// Kill process
    /// </summary>
    [Serializable]
    public class ProcessKillException : Exception
    {
        /// <summary>
        /// Ctor
        /// </summary>
        public ProcessKillException()
            :
            base("SYS:Poison pill")
        {
        }

        /// <summary>
        /// Ctor
        /// </summary>
        public ProcessKillException(string message) : base(message)
        {
        }

        /// <summary>
        /// Ctor
        /// </summary>
        public ProcessKillException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    /// <summary>
    /// Process inbox is full
    /// </summary>
    [Serializable]
    public class ProcessInboxFullException : Exception
    {
        /// <summary>
        /// Ctor
        /// </summary>
        public ProcessInboxFullException(ProcessId pid, int maximumSize, string type)
            :
            base("Process (" + pid + ") "+ type + " inbox is full (Maximum items: " + maximumSize + ")")
        {
        }
    }

    /// <summary>
    /// Session expired
    /// </summary>
    [Serializable]
    public class ProcessSessionExpired : Exception
    {
        /// <summary>
        /// Ctor
        /// </summary>
        public ProcessSessionExpired()
            :
            base("Session expired")
        {
        }
    }

    /// <summary>
    /// There are no children to route the message to
    /// </summary>
    [Serializable]
    public class NoRouterWorkersException : Exception
    {
        /// <summary>
        /// Ctor
        /// </summary>
        public NoRouterWorkersException()
            :
            base("Router has no workers")
        {
        }
    }
}
