pipeline {
    agent any
    parameters {
        string(name: 'GIT_HTTPS_PATH', defaultValue: 'https://github.com/tavisca-tgoyal/WebAppDemo.git')
        string(name: 'TEST_PROJECT_PATH', defaultValue: 'WebAppDemo.Tests/WebAppDemo.Tests.csproj')
        string(name: 'API_SOLUTION', defaultValue: 'WebAppDemo.sln')
        choice(name:'choices',choices: ['Both','Build', 'Test'])
    }
    stages {
        stage('Build') {
            steps {
               powershell '''
               dotnet restore $ENV:WORKSPACE\\$($env:API_SOLUTION) --source https://api.nuget.org/v3/index.json
               dotnet build $ENV:WORKSPACE\\$($env:API_SOLUTION) -p:Configration=release -o:C:\Users\tgoyal\Desktop\build files -v:q
               '''
              
            }
        }
        stage('Test') {
            steps {
              powershell'''
              dotnet test $ENV:WORKSPACE\\$($env:TEST_PROJECT_PATH)
              '''
            }
        }
        stage('Deploy') {
            steps {
                powershell '''                
                dotnet publish $ENV:WORKSPACE\\$($env:API_SOLUTION) -o:C:\Users\tgoyal\Desktop\publish files -c Release
                '''
            }
        }
    }
}
