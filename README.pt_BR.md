<!-- l10n-sync: source-file="README.md" -->
🌐 [English](README.md) | [Español](README.es.md)

<div align="center">

# 🎯 Soc Ops

**Social Bingo para encontros presenciais — e um laboratório prático para construir com o GitHub Copilot Agent Mode.**

[![.NET](https://img.shields.io/badge/.NET-10-512BD4?logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/download/dotnet/10.0)
[![Blazor](https://img.shields.io/badge/Blazor-WebAssembly-512BD4?logo=blazor&logoColor=white)](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor)
[![GitHub Copilot](https://img.shields.io/badge/GitHub-Copilot-181717?logo=github&logoColor=white)](https://github.com/features/copilot)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)
[![GitHub Pages](https://img.shields.io/badge/Deploy-GitHub%20Pages-222222?logo=githubpages&logoColor=white)](https://dotnet-presentations.github.io/vscode-github-copilot-agent-lab/)

[🎮 **Jogar**](https://dotnet-presentations.github.io/vscode-github-copilot-agent-lab/) &nbsp;•&nbsp; [📚 **Ver Guia do Lab**](https://dotnet-presentations.github.io/vscode-github-copilot-agent-lab/docs/) &nbsp;•&nbsp; [⚡ **Início Rápido**](#-início-rápido)

</div>

---

## ✨ O que é o Soc Ops?

O Soc Ops é **duas coisas em uma**:

| | |
|---|---|
| 🎲 **Um jogo** | Social Bingo para eventos presenciais — encontre pessoas que correspondam às perguntas e consiga 5 em linha para ganhar! |
| 🛠️ **Um workshop** | Um laboratório guiado de ~1 hora onde você usa o **VS Code Agent Mode** e o **GitHub Copilot** para estender e redesenhar o app do zero. |

> Construído com **C# · .NET 10 · Blazor WebAssembly** — roda no navegador sem necessidade de servidor.

---

## 🎓 O Que Você Vai Aprender

Percorra quatro partes práticas e adquira habilidades que você usará todos os dias:

| # | Habilidade | O que você fará |
|---|------------|----------------|
| 1 | **Engenharia de Contexto** | Ensine o GitHub Copilot sobre seu código com instruções personalizadas |
| 2 | **Desenvolvimento Design-First** | Redesenhe toda a UI guiando a IA com um brief criativo |
| 3 | **Agentes Personalizados** | Crie um agente Quiz Master que gera novos temas de bingo |
| 4 | **TDD Multi-Agente** | Implemente um novo modo de jogo com fluxos Red → Green → Refactor |

---

## 📚 Guia do Lab

| Parte | Título | Tempo |
|-------|--------|-------|
| [**00**](https://dotnet-presentations.github.io/vscode-github-copilot-agent-lab/docs/step.html?step=00-overview) | Visão Geral & Lista Rápida | — |
| [**01**](https://dotnet-presentations.github.io/vscode-github-copilot-agent-lab/docs/step.html?step=01-setup) | Configuração & Engenharia de Contexto | 15 min |
| [**02**](https://dotnet-presentations.github.io/vscode-github-copilot-agent-lab/docs/step.html?step=02-design) | Frontend Design-First | 15 min |
| [**03**](https://dotnet-presentations.github.io/vscode-github-copilot-agent-lab/docs/step.html?step=03-quiz-master) | Quiz Master Personalizado | 10 min |
| [**04**](https://dotnet-presentations.github.io/vscode-github-copilot-agent-lab/docs/step.html?step=04-multi-agent) | Desenvolvimento Multi-Agente | 20 min |

> 📝 Os guias do lab também estão disponíveis na pasta [`workshop/pt_BR/`](workshop/pt_BR/) para leitura offline.

---

## ⚡ Início Rápido

### Pré-requisitos

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0) ou superior
- [VS Code v1.107+](https://code.visualstudio.com/) com [GitHub Copilot](https://marketplace.visualstudio.com/items?itemName=GitHub.copilot) (Pro, Business ou Enterprise)

### Executar localmente

```bash
git clone https://github.com/<your-username>/my-soc-ops-csharp.git
cd my-soc-ops-csharp/SocOps
dotnet run
```

Depois abra `http://localhost:5000` no seu navegador.

### Compilar

```bash
cd SocOps
dotnet build
```

### Abrir no GitHub Codespaces ☁️

Pule a configuração local — tudo está pré-configurado:

1. Clique em **Code → Codespaces → Create codespace on main** no seu fork
2. Aguarde o devcontainer terminar
3. Execute `cd SocOps && dotnet run` no terminal

---

## 🏗️ Stack Tecnológico

| Camada | Tecnologia |
|--------|-----------|
| Linguagem | C# 13 |
| Framework | .NET 10 / Blazor WebAssembly |
| Estilos | CSS utilitário personalizado (`wwwroot/css/app.css`) |
| Hospedagem | GitHub Pages (deploy automático ao fazer push para `main`) |
| Ferramentas IA | GitHub Copilot Agent Mode no VS Code |

---

## 🤝 Contribuindo

Este projeto é um template de workshop — feedbacks e melhorias são bem-vindos!  
Consulte [CONTRIBUTING.md](CONTRIBUTING.md) e [CODE_OF_CONDUCT.md](CODE_OF_CONDUCT.md) para começar.

---

<div align="center">

Feito com ❤️ para eventos e workshops de desenvolvedores &nbsp;•&nbsp; [Licença MIT](LICENSE)

</div>
