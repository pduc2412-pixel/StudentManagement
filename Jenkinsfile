
pipeline {
    agent any

    stages {
        stage('Restore') {
            steps {
                sh 'dotnet restore StudentManagement.Tests/StudentManagement.Tests.csproj'
            }
        }

        stage('Build') {
            steps {
                sh 'dotnet build StudentManagement.csproj -c Release --no-restore'
            }
        }

        stage('Test') {
            steps {
                sh 'dotnet test StudentManagement.Tests/StudentManagement.Tests.csproj -c Release --no-restore --logger "junit;LogFilePath=TestResults/junit.xml"'
            }
        }
    }

    post {
        always {
            script {
                if (fileExists('StudentManagement.Tests/TestResults/junit.xml')) {
                    junit 'StudentManagement.Tests/TestResults/junit.xml'
                }
            }
        }
    }
}
