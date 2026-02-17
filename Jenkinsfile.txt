pipeline {
    agent any

    stages {
        stage('Checkout') {
            steps {
                checkout scm
            }
        }

        stage('Docker Build') {
            steps {
                script {
                    // API Gateway
                    sh "docker build -t apigateway -f APIGateway/Dockerfile ."

                    // Contact API
                    sh "docker build -t contactapi -f Services/ContactAPI/Contact.API/Dockerfile ."

                    // Reservation API
                    sh "docker build -t resapi -f Services/ResAPI/Reservation.API/Dockerfile ."
                }
            }
        }

        stage('Deploy with Docker Compose') {
            steps {
                sh 'docker-compose -f docker-compose.yml up -d --build'
            }
        }
    }
}