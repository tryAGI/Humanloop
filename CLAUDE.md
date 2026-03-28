# CLAUDE.md

## Project Overview

C# SDK for the [Humanloop](https://humanloop.com) API — prompt management with versioning, evaluations, datasets, and LLM observability.

## Quick Reference

```bash
# Build
dotnet build Humanloop.slnx

# Run tests (requires HUMANLOOP_API_KEY env var)
dotnet test src/tests/IntegrationTests/

# Regenerate from OpenAPI spec
cd src/libs/Humanloop && ./generate.sh
```

## Architecture

- **Generated client**: `src/libs/Humanloop/Generated/` (auto-generated, never edit)
- **Hand-written extensions**: `src/libs/Humanloop/Extensions/`
- **OpenAPI spec**: `src/libs/Humanloop/openapi.yaml` (manually maintained — Humanloop does not publish a public spec)
- **Tests**: `src/tests/IntegrationTests/Examples/`

## API Coverage

| Resource | Endpoints | Description |
|----------|-----------|-------------|
| Prompts | 15 | CRUD, versioning, deployment, call, log, serialize/deserialize |
| Datasets | 8 | CRUD, versioning, deployment |
| Evaluators | 10 | CRUD, versioning, deployment, logging, monitoring |
| Evaluations | 6 | Create, list, get, update status, runs, logs |
| Tools | 10 | CRUD, versioning, deployment, call, log |
| Flows | 9 | CRUD, versioning, deployment, log |
| Agents | 10 | CRUD, versioning, deployment, call, log |
| Directories | 4 | CRUD |
| Files | 2 | List, get by path |
| Logs | 3 | List, get, delete |

## MEAI Integration

`AIFunction` tools for use with any `IChatClient`:
- `AsListPromptsTool()` — List available prompts
- `AsGetPromptTool()` — Get prompt details and versions
- `AsListEvaluationsTool()` — List evaluations
- `AsListDatasetsTool()` — List datasets

## Auth

Bearer token via `HUMANLOOP_API_KEY` environment variable.

## Key Notes

- Base URL: `https://api.humanloop.com/v5`
- The OpenAPI spec was manually created from the official Fern-generated TypeScript/Python SDKs
- Source reference: https://github.com/humanloop/humanloop-node
