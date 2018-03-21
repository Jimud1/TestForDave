import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'story',
    templateUrl: './story.component.html'
})
export class FetchDataComponent {
    public story: IStoryModel[];

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        http.get(baseUrl + 'api/Story/1').subscribe(result => {
            this.story = result.json() as IStoryModel[];
        }, error => console.error(error));
    }
}

interface IStoryModel {
    storyId: number;
    title: string;
    conversations: {
        conversationText: string,
        conversationOptions: {
            conversationOptionText: string
        }
    }
};

