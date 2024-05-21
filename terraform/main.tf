terraform {
  backend "azurerm" {
    resource_group_name   = var.backend_resource_group_name
    storage_account_name  = var.backend_storage_account_name
    container_name        = var.backend_container_name
    key                   = var.backend_key
  }
  required_providers {
    azurerm = {
      source  = "hashicorp/azurerm"
      version = "~> 3.0"
    }
  }
  required_version = ">= 1.0"
}

provider "azurerm" {
  features {}
}

resource "azurerm_resource_group" "aks" {
  name     = var.resource_group_name
  location = var.location
}
