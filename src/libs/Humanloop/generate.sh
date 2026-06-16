#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

# Humanloop API does not publish a public OpenAPI spec.
# The spec is manually maintained in this directory based on the official SDKs and API docs.
# Source reference: https://github.com/humanloop/humanloop-node (Fern-generated TypeScript SDK)
install_autosdk_cli
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace tryAGI.Humanloop \
  --clientClassName HumanloopClient \
  --output Generated
