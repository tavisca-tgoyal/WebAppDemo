FROM mcr.microsoft.com/dotnet/core/aspnet

ARG project_name

WORKDIR /webapi

COPY /publish/. /webapi

EXPOSE 88

ENV env_project_name=$project_name

CMD ["sh","-c","dotnet ${env_project_name}"]
