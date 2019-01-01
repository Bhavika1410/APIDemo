import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';
import { map } from 'rxjs/operators';
import { ConfigService } from '../config.service';
import { User } from '../user';
import { Headers } from '@angular/http';

@Injectable()
export class DataService {

    _baseUrl = '';
    private headers = new Headers({ 'Content-Type': 'application/json' });
    constructor(public http: Http, private configService: ConfigService) {
        this._baseUrl = configService.getApiURI();
    }

    public AddUser(user: User) {
        return this.http.post(this._baseUrl + 'User/AddUser', JSON.stringify(user), { headers: this.headers })
            .pipe(map((res: Response) => res.json()));
    }
}
