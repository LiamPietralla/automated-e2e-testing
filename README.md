# Testing Command Docker

```bash
docker compose -f testing/compose.yml up -d --build
docker run --rm -v ./e2e:/app -w /app --network=e2e-testing_e2e-testing --entrypoint cypress cypress/included run -b chrome --config baseUrl=http://app:8080
docker compose -f testing/compose.yml down
```