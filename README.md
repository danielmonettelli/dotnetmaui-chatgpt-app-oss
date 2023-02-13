<p align="center">
<a href="https://github.com/danielmonettelli/dotnetmaui-chatgpt-oss#gh-light-mode-only">
<img width="300" src="https://raw.githubusercontent.com/danielmonettelli/dotnetmaui-chatgpt-oss/bf09fa30a93c68e32688c65f724d10b8fc3896bc/Assets/brand_light.svg#gh-light-mode-only">
</a>
<a href="https://github.com/danielmonettelli/dotnetmaui-chatgpt-oss#gh-dark-mode-only">
<img width="300" src="https://raw.githubusercontent.com/danielmonettelli/dotnetmaui-chatgpt-oss/bf09fa30a93c68e32688c65f724d10b8fc3896bc/Assets/brand_dark.svg#gh-dark-mode-only">
</a>
</p>

<p align="center">
  <a href="https://www.codacy.com/gh/danielmonettelli/dotnetmaui-chatgpt-oss/dashboard?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=danielmonettelli/dotnetmaui-chatgpt-oss&amp;utm_campaign=Badge_Grade">
  <img src="https://app.codacy.com/project/badge/Grade/9ca8b20992ef499a8930d4c8b8cebcbf" alt="Codacy Badge">
  </a>
  <a href="https://github.com/danielmonettelli/dotnetmaui-chatgpt-oss/actions/workflows/mobile.yml">
  <img src="https://github.com/danielmonettelli/dotnetmaui-chatgpt-oss/actions/workflows/mobile.yml/badge.svg" alt=".NET MAUI CI">
  </a>
  <a href="CODE_OF_CONDUCT.md">
    <img src="https://img.shields.io/badge/Contributor%20Covenant-2.1-4baaaa.svg" alt="Contributor Covenant">
  </a>
  <a href="LICENSE">
    <img src="https://img.shields.io/badge/license-MIT-blue.svg?style=flat-square" alt="License">
  </a>
</p>

<div align="center">

[![Open Source ❤](https://badges.frapsoft.com/os/v1/open-source.svg?v=103)](#open-source-) [![Stars](https://img.shields.io/github/stars/danielmonettelli/dotnetmaui-chatgpt-oss)](https://github.com/danielmonettelli/dotnetmaui-chatgpt-oss/stargazers) [![Forks](https://img.shields.io/github/forks/danielmonettelli/dotnetmaui-chatgpt-oss)](https://github.com/danielmonettelli/dotnetmaui-chatgpt-oss/network/members) [![Pull Requests](https://img.shields.io/github/issues-pr/danielmonettelli/dotnetmaui-chatgpt-oss)](https://github.com/danielmonettelli/dotnetmaui-chatgpt-oss/pulls) [![Issues](https://img.shields.io/github/issues/danielmonettelli/dotnetmaui-chatgpt-oss)](https://github.com/danielmonettelli/dotnetmaui-chatgpt-oss/issues) [![Contributors](https://img.shields.io/github/contributors/danielmonettelli/dotnetmaui-chatgpt-oss?color=2b9348)](https://github.com/danielmonettelli/dotnetmaui-chatgpt-oss/graphs/contributors)

</div>

[![Main Cover](https://raw.githubusercontent.com/danielmonettelli/dotnetmaui-chatgpt-oss/main/Assets/chatgpt_main_cover.png)](#Main-Cover)

Experience natural conversations with our **ChatGPT** application, built with **.NET MAUI** for simplicity and efficiency.

## Instructions

Before using the application, it is recommended to create an OpenAI account and generate your API key. You can manage your secret keys on the following OpenAI page.

- [OpenAI API Keys Page](https://platform.openai.com/account/api-keys).

Next, add the OpenAI API key to the `OpenAIToken` constant in the project, which is responsible for storing it.

```csharp
namespace ChatGPT.Constants
{
	public static class APIConstants
	{
		public const string OpenAIUrl = "https://api.openai.com/";
		public const string OpenAIToken = "OPENAI_API_KEY_HERE";

		public const string OpenAIEndpoint_Completions = "v1/completions";
		public const string OpenAIEndpoint_Generations = "v1/images/generations";
	}
}
```

## Features

|            | [<img src="https://raw.githubusercontent.com/danielmonettelli/NetMauiGPTApp/master/Assets/chatgpt.png" width="150">](#features) |
| -------------------------- | :----------------: |
| Experience smooth animation when switching between light and dark themes        |         ✔️         |
| Enjoy a harmonious interface on any screen size         |         In process of completion         |
| Enjoy a Lottie animation when the message list is empty          |         ✔️         |
| Ability to switch between text and image chat modes dynamically   |         ✔️   |
| The Border control automatically adjusts to the size of the message, whether it is short or long  |         In process of completion         |

## Supported platforms

|            | [<img src="https://raw.githubusercontent.com/danielmonettelli/dotnetmaui-chatgpt-oss/main/Assets/dotnetmaui.png" width="150">](#dotnetmaui) |
| -------------------------- | :----------------: |
| [<img src="https://raw.githubusercontent.com/danielmonettelli/dotnetmaui-chatgpt-oss/main/Assets/android.png" width="100">](#android) |         ✔️         |
| [<img src="https://raw.githubusercontent.com/danielmonettelli/dotnetmaui-chatgpt-oss/main/Assets/ios.png" width="100">](#iOS) |         ✔️         |
| [<img src="https://raw.githubusercontent.com/danielmonettelli/dotnetmaui-chatgpt-oss/main/Assets/windows.png" width="100">](#windows) |         ✔️         |
| [<img src="https://raw.githubusercontent.com/danielmonettelli/dotnetmaui-chatgpt-oss/main/Assets/macos.png" width="100">](#macos) |         ✔️         |

## Design tool

| [<img src="https://raw.githubusercontent.com/danielmonettelli/NetMauiGPTApp/master/Assets/penpot.png" width="150">](https://penpot.app) |
| -------------------------- |

## Tutorials

- [Making an app with ChatGPT in .NET MAUI _(Spanish)_.](https://www.youtube.com/watch?v=JE_SdgP-jJo)

## Publications

- [Building a ChatGPT in .NET MAUI _(Coming soon)_](https://danielmonettelli.github.io/)

## 👥 Contributions Core

| [<img src="https://avatars.githubusercontent.com/u/6038239?v=4" width="150">](https://github.com/icebeam7) | [<img src="https://avatars.githubusercontent.com/u/25359161?v=4" width="150">](https://github.com/BryanOroxon) | [<img src="https://avatars.githubusercontent.com/u/14121125?v=4" width="150">](https://github.com/danielmonettelli) |
|:---------------------------------------------:|:---------------------------------------------:|:---------------------------------------------:|
| **Luis Beltran** | **Bryan Oroxón** | **Daniel Monettelli** |

## Open Source ❤

It is with humility and gratitude that we offer our open source contributions to the .NET MAUI community, hoping to share a small grain of wisdom. If you decide to use this project, please feel free to acknowledge the contributions and dedication of all contributors.
