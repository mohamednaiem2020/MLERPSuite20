export interface possalesheader {
    tenantId: number;
    invoiceId: number;
    workFlowId: number;
    documentId: number;  
    transStatusId: number;
    invPOSSalesTypeId: number;
    invoiceCode: string;
    invoiceDate: string;
    terminalId: number;
    locationId: number;
    custId: number;
    totalAmount: number;
    netAmount: number;
    noteId: number;
    headerGuidId: string;
    createdBy: number;
    editedBy: number;
    createdDate: string;
    editedDate: number;
}

export interface possalesDetails {
    TenantId: number;
    InvoiceId: number;
    DetailsId: number;
    ItemId: number;
    UnitId: number;
    Quantity: number;
    Price: number;
    TotalAmount: number;
    NetAmount: number;
    DetailsGuidId: string;
}