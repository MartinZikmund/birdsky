using Birdsky.Core.Infrastructure;

namespace Birdsky.Services.Navigation;

public class FrameProvider : IFrameProvider
{
	private readonly IWindowShellProvider _windowShellProvider;

	public FrameProvider(IWindowShellProvider windowShellProvider)
	{
		_windowShellProvider = windowShellProvider;
	}

	public Frame GetForCurrentView() => _windowShellProvider.RootFrame;
}
