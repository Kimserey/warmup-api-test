#!/bin/bash

TIMEOUT=60

warmup() {
  for i in `seq $TIMEOUT`; do
    nc -zv $1 $2 2>&1
    result=$?

    if [ $result -eq 0 ]; then
      echo "Warmup [$3] response: $(curl -sS $3)"
      return 0
    fi
    sleep 1
  done

  echo "Warmup timed out for API '$1:$2'" >&2
  return 1
}

warmup $1 $2 $3

# Examples:
# ./warmup.sh localhost 5100 http://localhost:5100/api/test
# ./warmup.sh localhost 5000 http://localhost:5000/api/persons