docker build --no-cache -f SQL\Dockerfile.PostgreSql -t shop/postgre-sql ../SQL

docker build --no-cache -f Dockerfile -t shop/app ../..
