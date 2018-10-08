FROM alpine
COPY ./warmup .
RUN apk add --no-cache bash

RUN apk add --no-cache curl

CMD ["./wait-for-it.sh"]