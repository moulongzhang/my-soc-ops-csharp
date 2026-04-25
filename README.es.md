<!-- l10n-sync: source-file="README.md" -->
🌐 [English](README.md) | [Português (BR)](README.pt_BR.md)

<div align="center">

# 🎯 Soc Ops

**Social Bingo para encuentros presenciales — y un laboratorio práctico para construir con GitHub Copilot Agent Mode.**

[![.NET](https://img.shields.io/badge/.NET-10-512BD4?logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/download/dotnet/10.0)
[![Blazor](https://img.shields.io/badge/Blazor-WebAssembly-512BD4?logo=blazor&logoColor=white)](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor)
[![GitHub Copilot](https://img.shields.io/badge/GitHub-Copilot-181717?logo=github&logoColor=white)](https://github.com/features/copilot)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)
[![GitHub Pages](https://img.shields.io/badge/Deploy-GitHub%20Pages-222222?logo=githubpages&logoColor=white)](https://dotnet-presentations.github.io/vscode-github-copilot-agent-lab/)

[🎮 **Jugar**](https://dotnet-presentations.github.io/vscode-github-copilot-agent-lab/) &nbsp;•&nbsp; [📚 **Ver Guía del Lab**](https://dotnet-presentations.github.io/vscode-github-copilot-agent-lab/docs/) &nbsp;•&nbsp; [⚡ **Inicio Rápido**](#-inicio-rápido)

</div>

---

## ✨ ¿Qué es Soc Ops?

Soc Ops es **dos cosas en una**:

| | |
|---|---|
| 🎲 **Un juego** | Social Bingo para eventos presenciales — ¡encuentra personas que coincidan con las preguntas y consigue 5 en fila para ganar! |
| 🛠️ **Un workshop** | Un laboratorio guiado de ~1 hora donde usas **VS Code Agent Mode** y **GitHub Copilot** para extender y rediseñar la aplicación desde cero. |

> Construido con **C# · .NET 10 · Blazor WebAssembly** — se ejecuta en el navegador sin necesidad de servidor.

---

## 🎓 Lo Que Aprenderás

Trabaja en cuatro partes prácticas y adquiere habilidades que usarás todos los días:

| # | Habilidad | Qué harás |
|---|-----------|-----------|
| 1 | **Ingeniería de Contexto** | Enseña a GitHub Copilot sobre tu código con instrucciones personalizadas |
| 2 | **Desarrollo Design-First** | Rediseña toda la UI guiando a la IA con un brief creativo |
| 3 | **Agentes Personalizados** | Crea un agente Quiz Master que genera nuevos temas de bingo |
| 4 | **TDD Multi-Agente** | Implementa un nuevo modo de juego con flujos Red → Green → Refactor |

---

## 📚 Guía del Lab

| Parte | Título | Tiempo |
|-------|--------|--------|
| [**00**](https://dotnet-presentations.github.io/vscode-github-copilot-agent-lab/docs/step.html?step=00-overview) | Descripción General & Lista Rápida | — |
| [**01**](https://dotnet-presentations.github.io/vscode-github-copilot-agent-lab/docs/step.html?step=01-setup) | Configuración & Ingeniería de Contexto | 15 min |
| [**02**](https://dotnet-presentations.github.io/vscode-github-copilot-agent-lab/docs/step.html?step=02-design) | Frontend Design-First | 15 min |
| [**03**](https://dotnet-presentations.github.io/vscode-github-copilot-agent-lab/docs/step.html?step=03-quiz-master) | Quiz Master Personalizado | 10 min |
| [**04**](https://dotnet-presentations.github.io/vscode-github-copilot-agent-lab/docs/step.html?step=04-multi-agent) | Desarrollo Multi-Agente | 20 min |

> 📝 Las guías del lab también están disponibles en la carpeta [`workshop/es/`](workshop/es/) para lectura offline.

---

## ⚡ Inicio Rápido

### Requisitos Previos

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0) o superior
- [VS Code v1.107+](https://code.visualstudio.com/) con [GitHub Copilot](https://marketplace.visualstudio.com/items?itemName=GitHub.copilot) (Pro, Business o Enterprise)

### Ejecutar localmente

```bash
git clone https://github.com/<your-username>/my-soc-ops-csharp.git
cd my-soc-ops-csharp/SocOps
dotnet run
```

Luego abre `http://localhost:5000` en tu navegador.

### Compilar

```bash
cd SocOps
dotnet build
```

### Abrir en GitHub Codespaces ☁️

Omite la configuración local — todo está preconfigurado:

1. Haz clic en **Code → Codespaces → Create codespace on main** en tu fork
2. Espera a que el devcontainer termine
3. Ejecuta `cd SocOps && dotnet run` en la terminal

---

## 🏗️ Stack Tecnológico

| Capa | Tecnología |
|------|-----------|
| Lenguaje | C# 13 |
| Framework | .NET 10 / Blazor WebAssembly |
| Estilos | CSS utilitario personalizado (`wwwroot/css/app.css`) |
| Hosting | GitHub Pages (auto-deploy al hacer push a `main`) |
| Herramientas IA | GitHub Copilot Agent Mode en VS Code |

---

## 🤝 Contribuir

Este proyecto es una plantilla de workshop — ¡los comentarios y mejoras son bienvenidos!  
Consulta [CONTRIBUTING.md](CONTRIBUTING.md) y [CODE_OF_CONDUCT.md](CODE_OF_CONDUCT.md) para comenzar.

---

<div align="center">

Hecho con ❤️ para eventos y workshops de desarrolladores &nbsp;•&nbsp; [Licencia MIT](LICENSE)

</div>
