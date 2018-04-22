pipeline {
    agent any
    stages {
        stage('Build SSX') {
            steps {
                sh 'xvfb-run -a --server-args="-screen 0 1024x768x24" /opt/Unity/Editor/Unity -quit -batchmode -nographics -executeMethod BuildScript.BuildSSX -projectPath "/var/lib/jenkins/workspace/ssx" -logfile 2>&1'
            }
        }
    }
}