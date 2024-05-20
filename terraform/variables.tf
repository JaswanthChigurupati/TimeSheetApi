variable "backend_resource_group_name" {
  description = "The name of the resource group for the Terraform backend"
  type        = string
}

variable "backend_storage_account_name" {
  description = "The name of the storage account for the Terraform backend"
  type        = string
}

variable "backend_container_name" {
  description = "The name of the container for the Terraform backend"
  type        = string
}

variable "backend_key" {
  description = "The key for the Terraform state file"
  type        = string
}

variable "resource_group_name" {
  description = "The name of the resource group"
  type        = string
}

variable "location" {
  description = "The Azure location where the resources will be created"
  type        = string
}

variable "aks_cluster_name" {
  description = "The name of the AKS cluster"
  type        = string
}

variable "dns_prefix" {
  description = "The DNS prefix for the AKS cluster"
  type        = string
}

variable "node_count" {
  description = "The number of nodes in the AKS cluster"
  type        = number
}

variable "vm_size" {
  description = "The size of the virtual machines in the AKS cluster"
  type        = string
}

variable "network_plugin" {
  description = "The network plugin for the AKS cluster"
  type        = string
}

variable "load_balancer_sku" {
  description = "The load balancer SKU for the AKS cluster"
  type        = string
}
