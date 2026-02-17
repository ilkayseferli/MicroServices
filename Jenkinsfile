pipeline {
    agent any

    stages {
        stage('Checkout & Clean') {
            steps {
                cleanWs() // Eski dosya kalıntılarını sil
                checkout scm
            }
        }

        stage('Docker Build (No Cache)') {
            steps {
                script {
                    // İSİMLERİ DÜZELTTİK: docker-compose.yml ile birebir aynı yaptık
                    // --no-cache: ocelot.json'daki 8080 değişikliğini zorla içeri sokar
                    
                    sh "docker build --no-cache -t ilkayseferli/apigateway -f APIGateway/Dockerfile ."
                    sh "docker build --no-cache -t ilkayseferli/contactapi -f Services/ContactAPI/Contact.API/Dockerfile ."
                    sh "docker build --no-cache -t ilkayseferli/resapi -f Services/ResAPI/Reservation.API/Dockerfile ."
                }
            }
        }

        stage('Deploy') {
            steps {
                // down komutu eski ağ ve çakışan konteynerleri temizler
                sh 'docker-compose down'
                // --build eklemiyoruz çünkü yukarıda taze imajları zaten oluşturduk
                sh 'docker-compose up -d'
            }
        }
    }
}