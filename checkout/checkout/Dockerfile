FROM microsoft/dotnet:1.1-sdk
WORKDIR /home/hackathon/checkout/checkout/checkout

# copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# copy and build everything else
COPY . ./
RUN dotnet publish -c Release -o out

ENV ASPNETCORE_URLS http://*:5002
EXPOSE 5002

ENTRYPOINT ["dotnet", "out/checkout.dll"]
