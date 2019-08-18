FROM mcr.microsoft.com/dotnet/core/aspnet

ARG project_name

WORKDIR /mydir

COPY /publish/. /mydir

EXPOSE 88

ENV env_project_name=$project_name

CMD ["sh","-c","dotnet ${env_project_name}"]
