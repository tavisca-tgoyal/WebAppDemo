pipeline {
 
 agent any
 
 parameters{
 string(name: 'GIT_SOURCE_PATH', defaultValue: "https://github.com/tavisca-tgoyal/WebAppDemo.git")
 string(name: 'TEST_PATH', defaultValue: "WebAppDemo.Tests/WebAppDemo.Tests.csproj")
 string(name: 'SOLUTION_FILE_PATH', defaultValue: "WebAppDemo.sln")
 }
 stages {
 
 stage('--build--') {
 steps {
 sh "dotnet restore ${SOLUTION_FILE_PATH} --source https://api.nuget.org/v3/index.json"
 sh "dotnet build ${SOLUTION_FILE_PATH} -p:Configuration=release -v:n" 
 }
 }
 stage('--test--') {
 steps {
 sh "dotnet test ${TEST_PATH}"
 }
 }
 }
}