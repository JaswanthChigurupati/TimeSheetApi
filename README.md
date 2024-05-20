# Time Sheet CRUD API

This project is a Time Sheet CRUD API built with .NET 8.0, Docker, Terraform, and Kubernetes. The API allows for the management of time sheets with create, read, update, and delete operations. The deployment is managed using Terraform for infrastructure provisioning and GitHub Actions for CI/CD.

## Prerequisites

- .NET 8.0 SDK
- Docker
- Terraform
- Azure CLI
- kubectl
- GitHub account

## Project Structure

- **src/**: Contains the .NET 8.0 Web API project.
- **k8s/**: Kubernetes deployment and service YAML files.
- **terraform/**: Terraform configuration files for AKS.

## Setup and Deployment

### 1. Clone the Repository

```bash
git clone https://github.com/yourusername/timesheet-crud-api.git
cd timesheet-crud-api
