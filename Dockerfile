FROM weihanli/dotnet-exec:0.16.0
COPY entrypoint.sh /entrypoint.sh
ENTRYPOINT ["/entrypoint.sh"]