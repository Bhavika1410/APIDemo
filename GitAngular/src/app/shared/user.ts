export class User {
    UserId: number;
    EmailId: string;
    Password: string;
    IsActive: boolean;
    IsDeleted: boolean;
    constructor() {
        this.UserId = 0;
        this.EmailId = '';
        this.Password = '';
        this.IsActive = false;
        this.IsDeleted = false;
    }
}
