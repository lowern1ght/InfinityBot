using InfinityBot;
using InfinityBot.Modules;
using InfinityBot.Resources;
using InfinityBot.Properties;

using Serilog;
using Serilog.Configuration;
using Serilog.Sinks.SystemConsole;
using System.Diagnostics;

public record class Logger {
	private ILogger _logger { get; init; }
	
	public Logger() {
#if DEBUG
	_logger = new LoggerConfiguration()
			.MinimumLevel.Debug()
			.WriteTo.Console()
			.CreateLogger();
#else
	_logger = new LoggerConfiguration()
			.MinimumLevel.Information()
			.WriteTo.Console()
			.CreateLogger();
#endif
	}

	public Task Log(String logMessage, Serilog.Events.LogEventLevel logEventLevel, params Object[] param) {
		switch (logEventLevel) {
			case Serilog.Events.LogEventLevel.Debug: _logger.Debug(logMessage, param); break;
			case Serilog.Events.LogEventLevel.Information: _logger.Information(logMessage, param); break;
			case Serilog.Events.LogEventLevel.Warning: _logger.Warning(logMessage, param); break;
			case Serilog.Events.LogEventLevel.Error: _logger.Error(logMessage, param); break;
			case Serilog.Events.LogEventLevel.Fatal: _logger.Fatal(logMessage, param); break; }
		return Task.CompletedTask;
	}
}