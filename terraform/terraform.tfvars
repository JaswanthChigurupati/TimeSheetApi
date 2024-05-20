backend_resource_group_name = "terraform-storage-rg"
backend_storage_account_name = "terraformstate-timesheetapi"
backend_container_name = "tfstate-timesheetapi"
backend_key = "terraform.tfstate"

resource_group_name = "TimeSheetApi"
location = "uksouth"
aks_cluster_name = "aks-cluster-timesheetapi"
dns_prefix = "akscluster"
node_count = 2
vm_size = "Standard_DS2_v2"
network_plugin = "azure"
load_balancer_sku = "standard"
