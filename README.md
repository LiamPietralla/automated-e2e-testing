# Testing Command Docker

```bash
docker compose -f testing/compose.yml up -d --build
docker run --rm -v ${pwd}/e2e:/app -w /app --network=e2e-testing_e2e-testing --entrypoint cypress cypress/included:12.13.0 run -b firefox --config baseUrl=http://app:8080
docker compose -f testing/compose.yml down
```



docker run --rm -v ${pwd}/e2e:/app -w /app --entrypoint cypress cypress/included run -b chrome