
## AutoML
```bash
mlnet auto-train --task binary-classification --dataset "yelp_labelled.txt" --label-column-index 1 --has-header false --max-exploration-time 60
```

## Create REST API
```bash
dotnet new webapi -o API -lang f#
```