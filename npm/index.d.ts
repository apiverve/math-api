declare module '@apiverve/math' {
  export interface mathOptions {
    api_key: string;
    secure?: boolean;
  }

  /**
   * Describes fields the current plan does not unlock. Locked fields arrive as null
   * in `data`; `locked_fields` names them, using dot paths for nested fields.
   * Absent when the plan unlocks everything.
   */
  export interface PremiumInfo {
    message: string;
    upgrade_url: string;
    locked_fields: string[];
  }

  export interface mathResponse {
    status: string;
    error: string | null;
    data: MathCalculatorData;
    code?: number;
    premium?: PremiumInfo;
  }


  interface MathCalculatorData {
      result:    number | null;
      operation: null | string;
      input:     Input;
      steps:     (null | string)[];
  }
  
  interface Input {
      a: number | null;
      b: number | null;
  }

  export default class mathWrapper {
    constructor(options: mathOptions);

    execute(callback: (error: any, data: mathResponse | null) => void): Promise<mathResponse>;
    execute(query: Record<string, any>, callback: (error: any, data: mathResponse | null) => void): Promise<mathResponse>;
    execute(query?: Record<string, any>): Promise<mathResponse>;
  }
}
