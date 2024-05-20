
variable "resource_group_name" {
  description = "The name of the resource group"
  type        = string
  default     = "aks-resource-group"
}

variable "location" {
  description = "The Azure location where the resources will be created"
  type        = string
  default     = "East US"
}

variable "aks_cluster_name" {
  description = "The name of the AKS cluster"
  type        = string
  default     = "aks-cluster"
}

variable "dns_prefix" {
  description = "The DNS prefix for the AKS cluster"
  type        = string
  default     = "akscluster"
}

variable "node_count" {
  description = "The number of nodes in the AKS cluster"
  type        = number
  default     = 2
}

variable "vm_size" {
  description = "The size of the virtual machines in the AKS cluster"
  type        = string
  default     = "Standard_DS2_v2"
}
