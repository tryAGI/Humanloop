#!/bin/bash
set -e

# Humanloop API does not publish a public OpenAPI spec.
# The spec is manually maintained in this directory based on the official SDKs and API docs.
# Source reference: https://github.com/humanloop/humanloop-node (Fern-generated TypeScript SDK)

autosdk generate openapi.yaml \
  --namespace tryAGI.Humanloop \
  --clientClassName HumanloopClient \
  --output Generated
