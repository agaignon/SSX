pipeline {
    agent any
    stages {
        stage('Build SSX') {
            steps {
                sh '/opt/Unity/Editor/Unity -quit -batchmode -nographics -executeMethod BuildScript.BuildSSX -projectPath "/var/lib/jenkins/workspace/ssx" -logfile 2>&1'
            }
        }
    }
}