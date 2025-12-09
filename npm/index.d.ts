declare module '@apiverve/math' {
  export interface mathOptions {
    api_key: string;
    secure?: boolean;
  }

  export interface mathResponse {
    status: string;
    error: string | null;
    data: MathCalculatorData;
    code?: number;
  }


  interface MathCalculatorData {
      result:    number;
      operation: string;
      input:     Input;
      steps:     string[];
  }
  
  interface Input {
      a: number;
      b: number;
  }

  export default class mathWrapper {
    constructor(options: mathOptions);

    execute(callback: (error: any, data: mathResponse | null) => void): Promise<mathResponse>;
    execute(query: Record<string, any>, callback: (error: any, data: mathResponse | null) => void): Promise<mathResponse>;
    execute(query?: Record<string, any>): Promise<mathResponse>;
  }
}
