export class Resource {
    Name: string;
    Status: boolean;
    Location: string;

    Class: string;
    Provider: string;
    Type: string;
    ResType: string;

    Operations: Operation[];
    Attributes: Attribute[];
    Parameters: string;
}

export class Operation {
    Name: string;
    Timeout: string;
    Interval: string;
}

export class Attribute {
    Name: string;
    Value: string;
}