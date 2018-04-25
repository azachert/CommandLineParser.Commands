﻿using CommandLine;
using CommandLineParser.Commands;
using ProcessingCommands.Commands.Add;
using System;
using System.Threading.Tasks;

namespace ProcessingCommands
{
    class Program
    {
        public static async Task<int> Main(string[] args)
        {
            var commands = new ICommand[]
            {
                // add your commands here
                new AddCommand()
            };

            var parsed = Parser.Default.ParseArguments(args, commands);
            await parsed.WithParsedAsync(commands, returnValue =>
            {
                // consume returned value
            });
            parsed.WithNotParsed(result =>
            {
                // handle error
            });

            return 0;
        }
    }
}