#!/usr/bin/env bash
set -euo pipefail

# Humanloop API does not publish a public OpenAPI spec.
# The spec is manually maintained in this directory based on the official SDKs and API docs.
# Source reference: https://github.com/humanloop/humanloop-node (Fern-generated TypeScript SDK)

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace tryAGI.Humanloop \
  --clientClassName HumanloopClient \
  --output Generated
