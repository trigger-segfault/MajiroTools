﻿using System;
using System.IO;
using Majiro.Project;
using Majiro.Script;
using Majiro.Script.Analysis.ControlFlow;
using Majiro.Util;
using VToolBase.Cli;
using VToolBase.Core;

namespace MajiroTools.Commands {
	public class DisassembleCommand : Command {
		public DisassembleCommand(CommandParameters parameters) : base(parameters) { }

		public override string Name => "disassemble";

		public override string[] Description => new[] {
			"Disassembles a binary script file (.mjo) into an intermediate representation (.mjil)"
		};

		public override (string syntax, string description)[] Usage => new[] {
			("\absource", "Disassemble the \absource\a- script")
		};

		public override (char shorthand, string name, string fallback, string description)[] Flags => new[] {
			('e', "externalize", "true", "Whether to externalize message strings. Valid values are \abfalse\a-, \abtrue\a- and \aball\a-. \abtrue\a- only externalizes message strings, while \aball\a- exports all string literals."),
			('p', "print", "false", "Whether to print the disassembly to the console"),
			('f', "file", "true", "Whether to print the disassembly to a file"),
			('q', "quiet", "false", "Disable user-friendly output"),
			('w', "wait", "false", "Whether to wait after completing the command")
		};

		public override bool Execute() {
			if(Arguments.Length != 1)
				throw new Exception("Not enough arguments");

			string sourcePath = Arguments[0];
			string targetPath = Path.ChangeExtension(sourcePath, ".mjil");

			using var reader = File.OpenRead(sourcePath).NewReader();
			var script = Disassembler.DisassembleScript(reader);

			string projectPath = Parameters.GetString("project", null);
			if(projectPath != null) {
				script.Project = MjProject.Load(projectPath);
			}

			ControlFlowPass.Analyze(script);

			if(Parameters.GetBool("print", 'p', false)) {
				Disassembler.PrintScript(script, IColoredWriter.Console);
			}

			if(Parameters.GetBool("file", 'f', true)) {
				if(Parameters.GetBool("externalize", 'e', true)) {
					script.ExternalizeStrings(Parameters.GetString("externalize", 'e', null) == "all");
					string resourcePath = Path.ChangeExtension(sourcePath, ".mjres");
					using var s = File.Open(resourcePath, FileMode.Create);
					Disassembler.WriteResourceTable(script, s);
				}

				using var stream = File.Open(targetPath, FileMode.Create).NewTextWriter();
				Disassembler.PrintScript(script, new StreamColorWriter(stream));
			}

			Wait();
			return true;
		}
	}
}
