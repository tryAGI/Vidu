#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

# OpenAPI spec: locally maintained (Vidu has no public OpenAPI spec).
# Spec was handcrafted from https://platform.vidu.com/docs (viduhq/api-docs on
# GitHub covers a different, unrelated legacy "vidu.io" sales-video product).
install_autosdk_cli
rm -rf Generated

autosdk generate openapi.yaml \
  --namespace Vidu \
  --clientClassName ViduClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
