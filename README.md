🌐 [Português (BR)](README.pt_BR.md) | [Español](README.es.md)

<div align="center">

# 🎯 Soc Ops

**Social Bingo for in-person mixers — and a hands-on lab for building with GitHub Copilot Agent Mode.**

[![.NET](https://img.shields.io/badge/.NET-10-512BD4?logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/download/dotnet/10.0)
[![Blazor](https://img.shields.io/badge/Blazor-WebAssembly-512BD4?logo=blazor&logoColor=white)](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor)
[![GitHub Copilot](https://img.shields.io/badge/GitHub-Copilot-181717?logo=github&logoColor=white)](https://github.com/features/copilot)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)
[![GitHub Pages](https://img.shields.io/badge/Deploy-GitHub%20Pages-222222?logo=githubpages&logoColor=white)](https://dotnet-presentations.github.io/vscode-github-copilot-agent-lab/)

[🎮 **Play the Game**](https://dotnet-presentations.github.io/vscode-github-copilot-agent-lab/) &nbsp;•&nbsp; [📚 **View Lab Guide**](https://dotnet-presentations.github.io/vscode-github-copilot-agent-lab/docs/) &nbsp;•&nbsp; [⚡ **Quick Start**](#-quick-start)

</div>

---

## ✨ What is Soc Ops?

Soc Ops is **two things in one**:

| | |
|---|---|
| 🎲 **A game** | Social Bingo for in-person events — find people who match the prompts and get 5 in a row to win! |
| 🛠️ **A workshop** | A guided, ~1 hour lab where you use **VS Code Agent Mode** and **GitHub Copilot** to extend and redesign the app from scratch. |

> Built with **C# · .NET 10 · Blazor WebAssembly** — runs in the browser with no server required.

---

## 🎓 What You'll Learn

Work through four hands-on parts and pick up skills you'll use every day:

| # | Skill | What you'll do |
|---|-------|----------------|
| 1 | **Context Engineering** | Teach GitHub Copilot about your codebase using custom instructions |
| 2 | **Design-First Development** | Redesign the whole UI by guiding the AI with a creative brief |
| 3 | **Custom Agents** | Build a Quiz Master agent that generates new bingo card themes |
| 4 | **Multi-Agent TDD** | Ship a new game mode using Red → Green → Refactor agent workflows |

---

## 📚 Lab Guide

| Part | Title | Time |
|------|-------|------|
| [**00**](https://dotnet-presentations.github.io/vscode-github-copilot-agent-lab/docs/step.html?step=00-overview) | Overview & Checklist | — |
| [**01**](https://dotnet-presentations.github.io/vscode-github-copilot-agent-lab/docs/step.html?step=01-setup) | Setup & Context Engineering | 15 min |
| [**02**](https://dotnet-presentations.github.io/vscode-github-copilot-agent-lab/docs/step.html?step=02-design) | Design-First Frontend | 15 min |
| [**03**](https://dotnet-presentations.github.io/vscode-github-copilot-agent-lab/docs/step.html?step=03-quiz-master) | Custom Quiz Master | 10 min |
| [**04**](https://dotnet-presentations.github.io/vscode-github-copilot-agent-lab/docs/step.html?step=04-multi-agent) | Multi-Agent Development | 20 min |

> 📝 All lab guides are also available in the [`workshop/`](workshop/) folder for offline reading.

---

## ⚡ Quick Start

### Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0) or higher
- [VS Code v1.107+](https://code.visualstudio.com/) with [GitHub Copilot](https://marketplace.visualstudio.com/items?itemName=GitHub.copilot) (Pro, Business, or Enterprise)

### Run locally

```bash
git clone https://github.com/<your-username>/my-soc-ops-csharp.git
cd my-soc-ops-csharp/SocOps
dotnet run
```

Then open `http://localhost:5000` in your browser.

### Build

```bash
cd SocOps
dotnet build
```

### Open in GitHub Codespaces ☁️

Skip local setup entirely — everything is pre-configured:

1. Click **Code → Codespaces → Create codespace on main** on your fork
2. Wait for the devcontainer to finish
3. Run `cd SocOps && dotnet run` in the terminal

---

## 🏗️ Tech Stack

| Layer | Technology |
|-------|-----------|
| Language | C# 13 |
| Framework | .NET 10 / Blazor WebAssembly |
| Styling | Custom CSS utilities (`wwwroot/css/app.css`) |
| Hosting | GitHub Pages (auto-deploy on push to `main`) |
| AI Tooling | GitHub Copilot Agent Mode in VS Code |

---

## 🤝 Contributing

This project is a workshop template — feedback and improvements are welcome!  
See [CONTRIBUTING.md](CONTRIBUTING.md) and [CODE_OF_CONDUCT.md](CODE_OF_CONDUCT.md) to get started.

---

<div align="center">

Made with ❤️ for developer events and workshops &nbsp;•&nbsp; [MIT License](LICENSE)

</div>
