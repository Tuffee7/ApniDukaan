#!/usr/bin/env bash
set -e

HOST="${DB_HOST:-db}"
PORT="${DB_PORT:-1433}"
RETRIES=30
SLEEP=2

echo "Waiting for SQL Server at $HOST:$PORT..."
i=0
until nc -z "${HOST}" "${PORT}" || [ $i -ge $RETRIES ]; do
  i=$((i+1))
  sleep $SLEEP
done

if [ $i -ge $RETRIES ]; then
  echo "SQL Server did not become available in time"
  exit 1
fi

echo "Applying EF Core migrations..."
# Adjust project paths if your project files are located elsewhere in the image
dotnet ef database update --no-build --project /app/ApniDukaan.API/ApniDukaan.API.csproj --startup-project /app/ApniDukaan.API/ApniDukaan.API.csproj

echo "Migrations applied. Starting app..."
exec dotnet /app/ApniDukaan.API/ApniDukaan.API.dll
