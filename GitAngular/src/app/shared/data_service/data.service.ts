import { Injectable } from '@angular/core';
import { Http, Response, RequestOptions } from '@angular/http';
import { map } from 'rxjs/operators';
import { ConfigService } from '../config.service';
import { User } from '../user';
import { Headers } from '@angular/http';

@Injectable()
export class DataService {

    _baseUrl = '';
    // private headers = new Headers({ 'Content-Type': 'application/json' });
    constructor(public http: Http, private configService: ConfigService) {
        this._baseUrl = configService.getApiURI();
    }

    public AddUser(user: User) {
        const headers = new Headers();
        headers.append('enctype', 'multipart/form-data');
        headers.append('Accept', 'application/json');
        const options = new RequestOptions({ headers: headers });
        return this.http.post(this._baseUrl + 'User/AddUser', user,  options)
            .pipe(map((res: Response) => res.json()));
    }
}
