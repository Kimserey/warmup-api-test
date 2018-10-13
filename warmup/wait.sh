#!/bin/sh

./wait-for.sh --timeout=60 localhost:5100 -- curl -sS http://localhost:5100/api/
./wait-for.sh --timeout=60 localhost:5000 -- curl -sS http://localhost:5000/api/persons